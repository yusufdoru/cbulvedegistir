using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Author : Yusuf Doru
/// Web : www.yusufdoru.com

namespace seekanddestroy
{
    public partial class Form1 : Form
    {
        string file = "";
        List<string> files = null;
        Dictionary<string, string> degisecekkelimeler = null;
        
        Thread t = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            CheckForIllegalCrossThreadCalls = false;            
            degisecekkelimeler = new Dictionary<string, string>();
            
        }
        void BulveDegistir()
        {
            try
            {                
                files = Directory.GetFiles(txtAnaKlasor.Text, "*.*", SearchOption.AllDirectories).ToList();
                btnBulveDegistir.Enabled = false;
                btnGirisleriTemizle.Enabled = false;
                for (int i = 0; i < files.Count; i++)
                {
                    file = files[i];

                    if (lbDegisecekDosyalar.Items.Count > 0)
                    {

                        for (int j = 0; j < lbDegisecekDosyalar.Items.Count; j++)
                        {
                            if (new FileInfo(file).Name.Equals(lbDegisecekDosyalar.Items[j].ToString()))
                            {
                                DosyaDegistir(file, degisecekkelimeler);
                                lblDurum.Text = (i + 1).ToString() + " / " + files.Count + " \"" + file + "\" güncellendi.";            
                            }
                                
                        }

                    }
                    else
                    {
                        DosyaDegistir(file, degisecekkelimeler);
                        lblDurum.Text = (i + 1).ToString() + " / " + files.Count + " \"" + file + "\" güncellendi.";            
                    }                    
                    
                }
                lblDurum.Text = "Güncelleme işlemleri başarıyla tamamlandı.";

                btnGirisleriTemizle.Enabled = true;
                btnBulveDegistir.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            t = null;

        }        
        void DosyaDegistir(string dosyayolu, Dictionary<string, string> degisecekler)
        {
            string icerik = "";
            
            icerik = File.ReadAllText(dosyayolu, Encoding.Default);
            foreach (var i in degisecekler)
            {
                icerik = icerik.Replace(i.Key,i.Value);
            }
            File.WriteAllText(dosyayolu, icerik, Encoding.Default);

        }

        void AddDegisecekKelime()
        {
            try
            {
                if (txtDegisecekKelime.Text != "" && txtDegisenKelime.Text != "")
                {

                    degisecekkelimeler.Add(txtDegisecekKelime.Text, txtDegisenKelime.Text);
                    lbDegisecekKelimeler.Items.Add(txtDegisecekKelime.Text + " > " + txtDegisenKelime.Text);

                    txtDegisecekKelime.Text = "";
                    txtDegisenKelime.Text = "";
                    txtDegisecekKelime.Focus();

                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);

            }
        }
        private void btnBulveDegistir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                t = new Thread(new ThreadStart(BulveDegistir));
                t.Start();
            }
        }
        
        private void lbDegisecekDosyalar_DoubleClick(object sender, EventArgs e)
        {
              if (lbDegisecekDosyalar.SelectedItem != null) if (lbDegisecekDosyalar.SelectedItem.ToString().Length != 0) lbDegisecekDosyalar.Items.RemoveAt(lbDegisecekDosyalar.SelectedIndex);
        }
        private void lbDegisecekKelimeler_DoubleClick(object sender, EventArgs e)
        {
            if (lbDegisecekKelimeler.SelectedItem != null)
                if (lbDegisecekKelimeler.SelectedItem.ToString().Length != 0)
                {
                    degisecekkelimeler.Remove(degisecekkelimeler.ElementAt(lbDegisecekKelimeler.SelectedIndex).Key);
                    lbDegisecekKelimeler.Items.RemoveAt(lbDegisecekKelimeler.SelectedIndex);                    
                }
        }
        private void txtDegisecekDosyaAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                if (txtDegisecekDosyaAdi.Text != "")
                {
                    lbDegisecekDosyalar.Items.Add(txtDegisecekDosyaAdi.Text);
                    txtDegisecekDosyaAdi.Text = "";
                }
                else
                {
                    MessageBox.Show("Dosya adını giriniz!");
                }
            }
        }

        private void txtDegisenKelime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                AddDegisecekKelime();                
            }
        }

        private void txtDegisecekKelime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                AddDegisecekKelime();
            }
        }
        private void btnGirisleriTemizle_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "Durum";
            lbDegisecekDosyalar.Items.Clear();
            lbDegisecekKelimeler.Items.Clear();
            txtDegisecekKelime.Text = "";
            txtDegisenKelime.Text = "";
            degisecekkelimeler.Clear();
        }

       

    }  
}


