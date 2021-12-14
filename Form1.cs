using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Verme_Teknikleri
{
    public partial class Karar_Verme : Form
    {
        #region ATRIBUTET
        int satir = 0;
        int sutun = 0;
        #endregion ATRIBUTET

        #region NDERTIMI
        public Karar_Verme()
        {
            InitializeComponent();
        }
        #endregion NDERTIMI

        #region METODAT
        //********************************
      public string Vlerat(int sutun, int satir, DataGridView dgvPolinomio)
        {
            object vlera = dgvPolinomio[satir, sutun].Value;
            return vlera == null ? "" : vlera.ToString();
        }

        //*********************************
        public void AktivizoMatrix()
        {
            if (int.TryParse(tbFila1.Text, out satir) & int.TryParse(tbColumn1.Text, out sutun))
            {
                dgvMatrix1.ColumnCount = sutun;
                dgvMatrix1.RowCount = satir;
                dgvMatrix1.Visible = true;
            }

            for (int i = 0; i < satir; i++)
            {
                dgvMatrix1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < sutun; j++)
                {
                    dgvMatrix1.Columns[j].HeaderText = (j + 1).ToString();
                    dgvMatrix1.Columns[j].Width = 40;
                    dgvMatrix1[j, i].Value = 0;

                }

            }

        }



        #endregion METODAT


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbColumn1_Leave(object sender, EventArgs e)
        {
            AktivizoMatrix();

        }

        private void veri_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string alternativa1, alternativa2, alternativa4, alternativa5;
            int max = 0;
            int min = 0;
            float[] avg = new float[satir];

            #region GETIR
            if (type.SelectedItem == "Getir") // Getir
            {

                    #region IYIMSERLIK
                for (int k = 0; k < sutun; k++)
                {
                    for (int l = 0; l < satir; l++)
                    {
                        if (max <= Convert.ToInt32(dgvMatrix1[k, l].Value))    //Iyimserlik
                        {
                            //max = ((int)(Matrix[i,j]));
                            var val = dgvMatrix1[k, l].Value;
                            max = Convert.ToInt32(val);
                            alternativa1 = (val).ToString();
                            label1.Text = (l + 1).ToString();
                        }
                    }
                }
                #endregion IYIMSERLIK

                    #region KOTUMSERLIK

                //***************************************************************************************************
                
                
                int [] kotumserlik = new int[satir];
                int t = 0;
                for (int k = 0; k < satir; k++)
                {
                    int mink = 100;
                    for (int l = 0; l < sutun; l++)
                        
                    {
                        if (mink >= Convert.ToInt32(dgvMatrix1[l, k].Value))    
                        {
                            var val = dgvMatrix1[l, k].Value;
                            mink = Convert.ToInt32(val);
                        }     
                    }
                    kotumserlik[t] = mink;
                    t++;
                }

                int maxk = kotumserlik[0];
                for(int k = 0; k < t; k++)
                {
                    if (maxk <= kotumserlik[k])
                    {
                        maxk = kotumserlik[k];
                        alternativa2 = (k + 1).ToString();
                        label2.Text = alternativa2;
                    }
                }

                #endregion KOTUMSERLIK

                    #region ES_OLASILIK

                //***********************************************************************************************************
                int sum ;
                float average;                                        //es olasilik
                float mesatarja = 0;
                int i;
                for (int k = 0; k < satir; k++)
                {
                    sum = 0;
                    average = 0;
                    for (int l = 0; l < sutun; l++)

                        sum = sum + Convert.ToInt32(dgvMatrix1[l, k].Value); 
                        average = sum / sutun;
                        if (average >= mesatarja)
                        {
                            mesatarja = average;
                            i = k;
                        }
                    label3.Text = (k + 1).ToString();
                }

                    #endregion ES_OLASILIK

                    #region HURWICS
                    //***************************************************************************************************************

                    max = Convert.ToInt32(dgvMatrix1[0, 0].Value);
                    min = Convert.ToInt32(dgvMatrix1[0, 0].Value);
                    decimal alpha = alphano.Value;
                    decimal hurwics = 0;
                    decimal h;
                    string vlera;

                    for (int l = 0; l < satir; l++)
                    {
                        min = 100; 
                        max = 0;
                        for (int k = 0; k < sutun; k++)
                        {
                            if (min >= Convert.ToInt32(dgvMatrix1[k, l].Value))   
                            {
                                var val = dgvMatrix1[k, l].Value;
                                min = Convert.ToInt32(val);
                            }
                            if (max <= Convert.ToInt32(dgvMatrix1[k, l].Value))
                            {
                                var val = dgvMatrix1[k, l].Value;
                                max = Convert.ToInt32(val);
                            }
                            
                        }
                        h = ((alpha * max) + ((1 - alpha) * min));
                        if (h >= hurwics)
                        {
                            hurwics = h;
                            alternativa5 = (l + 1).ToString();
                            label5.Text = alternativa5; 
                        }
                    }

                    #endregion HURWICS

                    #region PISMANLIK

                      //***********************************************************************************
                      

                       int [,] matrix2 = new int[sutun, satir];
                       int j = 0;
                       int[] arraysatir = new int[satir];
                       int[] arraysutun = new int[sutun];
                       
                       int maxd;

                for (int l = 0; l < sutun; l++)
                     {
                       MessageBox.Show("sutun= " + l);
                       int maxp = 0;
                           for (int k = 0; k < satir; k++)
                           {
                         MessageBox.Show("satir= " + k);
                           MessageBox.Show("kutunun degeri= " + Convert.ToInt32(dgvMatrix1[l, k].Value));

                        if (maxp <= Convert.ToInt32(dgvMatrix1[l, k].Value))    //max x sutun => array
                               {
                                   var val = dgvMatrix1[l, k].Value;
                                   maxp = Convert.ToInt32(val);
                                 MessageBox.Show("sutunun max degeri " + maxp);
                               }
                           }
                           arraysutun[j] = maxp;
                           MessageBox.Show("arraydeki deger= " + arraysutun[j]);
                           j++;
                     }

                j = 0;
                MessageBox.Show("sutun= " + sutun);
                MessageBox.Show("satir= " + satir);

                for (int l = 0; l < sutun; l++)
                    {      MessageBox.Show("sutun= " + l);                           //yeni matrix olustur 

                    for (int k = 0; k < satir; k++)
                    {
                        MessageBox.Show("satir= " + k);
                        MessageBox.Show("eski deger= " + Convert.ToInt32(dgvMatrix1[l, k].Value));
 
                        matrix2[l, k] = arraysutun[j] - Convert.ToInt32(dgvMatrix1[l, k].Value);
                        MessageBox.Show("yeni deger= " + matrix2[l, k]);     //nuk kalon ne qelizen e fundit
                    }   
                           
                               j++;
                               MessageBox.Show("j= " + j);
                     }


                int p = 0;
                for (int k = 0; k < satir; k++)
                {
                     MessageBox.Show("Suan " + k + ". satirdayim");
                    maxd = 0;
                    for (int l = 0; l < sutun; l++)

                    {
                           MessageBox.Show("Suan " + l + ". sutundayim");
                         MessageBox.Show("kutucukta ki deger" + matrix2[l, k]);
                        if (maxd <= matrix2[l, k])
                        { 
                            var val = matrix2[l, k];
                            maxd = Convert.ToInt32(val);
                               MessageBox.Show("yeni max " +maxd );

                        }
                    }
                    arraysatir[p] = maxd;
                    p++;
                }

                int minp = arraysatir[0];
                MessageBox.Show("dizinin ilk degeri" + minp);
                for (int k = 0; k < p; k++)
                {
                    if (minp >= arraysatir[k])
                    {
                        minp = arraysatir[k];
                             MessageBox.Show("eski min degerim buyuk oldugu icin yeni min degerim = " + minp);
                        alternativa4 = (k + 1).ToString();
                        label4.Text = alternativa4;
                    }
                }



                #endregion PISMANLIK

            }
            #endregion GETIR

            #region MALIYET

            else if (type.SelectedItem == "Maliyet")
            {
                #region IYIMSERLIK
                int mini = 100;
                for (int k = 0; k < sutun; k++)
                {
                    for (int l = 0; l < satir; l++)
                    {
                        if (mini >= Convert.ToInt32(dgvMatrix1[k, l].Value))    //Iyimserlik
                        {
                            var val = dgvMatrix1[k, l].Value;
                            mini = Convert.ToInt32(val);
                            alternativa1 = (val).ToString();
                            label1.Text = (l + 1).ToString();
                        }
                    }
                }

                #endregion IYIMSERLIK

                #region KOTUMSERLIK

                int[] kotumserlik = new int[satir];
                int t = 0;
                for (int k = 0; k < satir; k++)
                {
                    // MessageBox.Show("Suan " + k + ". satirdayim");
                    int maxmk = 0;
                    for (int l = 0; l < sutun; l++)

                    {
                        //   MessageBox.Show("Suan " + l + ". sutundayim");
                        // MessageBox.Show("kutucukta ki deger" + Convert.ToInt32(dgvMatrix1[l, k].Value));
                        if (maxmk <= Convert.ToInt32(dgvMatrix1[l, k].Value))
                        {
                            var val = dgvMatrix1[l, k].Value;
                            maxmk = Convert.ToInt32(val);
                            //   MessageBox.Show("yeni minimum " +mink );

                        }
                    }
                    kotumserlik[t] = maxmk;
                    t++;
                }

                int mink = kotumserlik[0];
                //MessageBox.Show("dizinin ilk degeri" + maxk);
                for (int k = 0; k < t; k++)
                {
                    if (mink >= kotumserlik[k])
                    {
                        mink = kotumserlik[k];
                        //      MessageBox.Show("eski maksimum degerim kucuk oldugu icin yeni buyuk degerim = " + maxk);
                        alternativa2 = (k + 1).ToString();
                        label2.Text = alternativa2;
                    }
                }

                #endregion KOTUMSERLIK

                #region ES_OLASILIK

                //***********************************************************************************************************
                int sum;
                float average;                                        //es olasilik
                float mesatarja = 100;
                int i;
                for (int k = 0; k < satir; k++)
                {
                    sum = 0;
                    average = 0;
                    for (int l = 0; l < sutun; l++)

                        sum = sum + Convert.ToInt32(dgvMatrix1[l, k].Value);
                    //MessageBox.Show("mbledhja = " + sum);
                    average = sum / sutun;
                    //MessageBox.Show("mesatarja = " + average);
                    if (average <= mesatarja)
                    {
                        mesatarja = average;
                        i = k;
                        //MessageBox.Show("mesatarja min = " + average);
                    }
                    label3.Text = (k + 1).ToString();
                }

                #endregion ES_OLASILIK

                #region HURWICS

                max = Convert.ToInt32(dgvMatrix1[0, 0].Value);
                min = Convert.ToInt32(dgvMatrix1[0, 0].Value);
                decimal alpha = alphano.Value;
                decimal hurwics = 1000;
                decimal h;
                string vlera;

                for (int l = 0; l < satir; l++)
                {
                    min = 100; //vlere me te madhe se 100 nuk punon
                    max = 0;
                    for (int k = 0; k < sutun; k++)
                    {
                        if (min >= Convert.ToInt32(dgvMatrix1[k, l].Value))    //Hurwics
                        {
                            var val = dgvMatrix1[k, l].Value;
                            min = Convert.ToInt32(val);
                        }
                        //MessageBox.Show("min=" + min);
                        if (max <= Convert.ToInt32(dgvMatrix1[k, l].Value))
                        {
                            var val = dgvMatrix1[k, l].Value;
                            max = Convert.ToInt32(val);
                        }
                        //MessageBox.Show("max=" + max);
                    }
                    h = ((alpha * min) + ((1 - alpha) * max));
                    if (h >= hurwics)
                    {
                        hurwics = h;
                        //MessageBox.Show(hurwics.ToString());
                        alternativa5 = (l + 1).ToString();
                        label5.Text = alternativa5; //pse nuk punon kur e vendosi jashte kllapes
                    }
                }
                #endregion HURWICS

                #region PISMANLIK

                //***********************************************************************************


                int[,] matrix2 = new int[sutun, satir];
                int j = 0;
                int[] arraysatir = new int[satir];
                int[] arraysutun = new int[sutun];

                int maxd;

                for (int l = 0; l < sutun; l++)
                {
                    MessageBox.Show("sutun= " + l);
                    int minmp = 1000;
                    for (int k = 0; k < satir; k++)
                    {
                        MessageBox.Show("satir= " + k);
                        MessageBox.Show("kutunun degeri= " + Convert.ToInt32(dgvMatrix1[l, k].Value));

                        if (minmp <= Convert.ToInt32(dgvMatrix1[l, k].Value))    //min x sutun => array
                        {
                            var val = dgvMatrix1[l, k].Value;
                            minmp = Convert.ToInt32(val);
                            MessageBox.Show("sutunun max degeri " + minmp);
                        }
                    }
                    arraysutun[j] = minmp;
                    MessageBox.Show("arraydeki deger= " + arraysutun[j]);
                    j++;
                }

                j = 0;
                MessageBox.Show("sutun= " + sutun);
                MessageBox.Show("satir= " + satir);

                for (int l = 0; l < sutun; l++)
                {
                    MessageBox.Show("sutun= " + l);                           //yeni matrix olustur 

                    for (int k = 0; k < satir; k++)
                    {
                        MessageBox.Show("satir= " + k);
                        MessageBox.Show("eski deger= " + Convert.ToInt32(dgvMatrix1[l, k].Value));
                        //var val = dgvMatrix1[k, l].Value;
                        matrix2[l, k] =  Convert.ToInt32(dgvMatrix1[l, k].Value) - arraysutun[j];
                        MessageBox.Show("yeni deger= " + matrix2[l, k]);     //nuk kalon ne qelizen e fundit
                    }

                    j++;
                    MessageBox.Show("j= " + j);
                }


                int p = 0;
                for (int k = 0; k < satir; k++)
                {
                    MessageBox.Show("Suan " + k + ". satirdayim");
                    maxd = 0;
                    for (int l = 0; l < sutun; l++)

                    {
                        MessageBox.Show("Suan " + l + ". sutundayim");
                        MessageBox.Show("kutucukta ki deger" + matrix2[l, k]);
                        if (maxd <= matrix2[l, k])
                        {
                            var val = matrix2[l, k];
                            maxd = Convert.ToInt32(val);
                            MessageBox.Show("yeni max " + maxd);

                        }
                    }
                    arraysatir[p] = maxd;
                    p++;
                }

                int minp = arraysatir[0];
                MessageBox.Show("dizinin ilk degeri" + minp);
                for (int k = 0; k < p; k++)
                {
                    if (minp >= arraysatir[k])
                    {
                        minp = arraysatir[k];
                        MessageBox.Show("eski min degerim buyuk oldugu icin yeni min degerim = " + minp);
                        alternativa4 = (k + 1).ToString();
                        label4.Text = alternativa4;
                    }
                }




                #endregion PISMANLIK


            }
            #endregion MALIYET

        }

        private void button2_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void typename_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Karar_Verme_Load(object sender, EventArgs e)
        {

        }
    }
} 
 
 