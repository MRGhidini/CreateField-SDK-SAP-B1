using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAPbobsCOM;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace CreateField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //CreateRegistro
            Settings.VerifyRegistro();

            //ReadRegistro
            try
            {
                servidor.Text = Settings.LerRegistro("Server");
                basededados.Text = Settings.LerRegistro("BaseName");
                comboBox1.Text = Settings.LerRegistro("SQLType");
                userdb.Text = Settings.LerRegistro("UserDB");
                senhadb.Text = Settings.LerRegistro("PwDB");
                usersap.Text = Settings.LerRegistro("UserSAP");
                senhasap.Text = Settings.LerRegistro("PwSAP");
                license.Text = Settings.LerRegistro("LicenServer");
            }
            catch (Exception ex)
            {
                return;
            }
            

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            Settings.GravarRegistro("Server", servidor.Text);
            Settings.GravarRegistro("BaseName", basededados.Text);
            Settings.GravarRegistro("SQLType", comboBox1.Text);
            Settings.GravarRegistro("UserDB", userdb.Text);
            Settings.GravarRegistro("PwDB", senhadb.Text);
            Settings.GravarRegistro("UserSAP", usersap.Text);
            Settings.GravarRegistro("PwSAP", senhasap.Text);
            Settings.GravarRegistro("LicenServer", license.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.GravarRegistro("Server", servidor.Text);
            Settings.GravarRegistro("BaseName", basededados.Text);
            Settings.GravarRegistro("SQLType", comboBox1.Text);
            Settings.GravarRegistro("UserDB", userdb.Text);
            Settings.GravarRegistro("PwDB", senhadb.Text);
            Settings.GravarRegistro("UserSAP", usersap.Text);
            Settings.GravarRegistro("PwSAP", senhasap.Text);
            Settings.GravarRegistro("LicenServer", license.Text);


            Company oCompany = new Company();

            if (oCompany.Connected == false)
            {

                if(comboBox1.Text == "2005")
                {
                    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2005;
                }
                else if (comboBox1.Text == "2008")
                {
                    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2008;
                }
                else if (comboBox1.Text == "2012")
                {
                    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2012;
                }
                else if (comboBox1.Text == "2014")
                {
                    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2014;
                }
                else if (comboBox1.Text == "HANA")
                {
                    oCompany.DbServerType = BoDataServerTypes.dst_HANADB;
                }

                oCompany.Server = servidor.Text;
                oCompany.CompanyDB = basededados.Text;
                oCompany.DbUserName = userdb.Text;
                oCompany.DbPassword = senhadb.Text;
                oCompany.UserName = usersap.Text;
                oCompany.Password = senhasap.Text;
                oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                oCompany.LicenseServer = license.Text;

                int i = oCompany.Connect();

                if (i != 0)
                {
                    MessageBox.Show("SAP not connected, erro: " + oCompany.GetLastErrorDescription(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (namecampo.Text != "" && aliascampo.Text != "" && tipocampo.Text != "" && tabelacampo.Text != "")
                    {
                        principal p = new principal(oCompany);

                        if (tipocampo.Text == "Valor")
                        {
                            i = p.CriaCampo(namecampo.Text, aliascampo.Text, Convert.ToInt32(tamanhocampo.Text), BoFieldTypes.db_Float, BoFldSubTypes.st_Sum, tabelacampo.Text);
                        }
                        if (tipocampo.Text == "Numerico")
                        {
                            i = p.CriaCampo(namecampo.Text, aliascampo.Text, Convert.ToInt32(tamanhocampo.Text), BoFieldTypes.db_Numeric, BoFldSubTypes.st_Quantity, tabelacampo.Text);
                        }
                        if (tipocampo.Text == "Data")
                        {
                            i = p.CriaCampo(namecampo.Text, aliascampo.Text, 10, BoFieldTypes.db_Date, BoFldSubTypes.st_None, tabelacampo.Text);
                        }
                        if (tipocampo.Text == "Texto")
                        {
                            i = p.CriaCampo(namecampo.Text, aliascampo.Text, Convert.ToInt32(tamanhocampo.Text), BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, tabelacampo.Text);
                        }

                        MessageBox.Show("Process carried out, check the created field!", "Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        namecampo.Text = "";
                        aliascampo.Text = "";
                        tamanhocampo.Text = "";
                        tipocampo.Text = "";
                        tabelacampo.Text = "";
                    }
                    else 
                    {
                        MessageBox.Show("Please fill in all fields ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void servidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tipocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipocampo.SelectedItem.ToString() == "Data")
            {
                tamanhocampo.Enabled = false;
            }
            else
            {
                tamanhocampo.Enabled = true;
            }
            

        }

    }
}
