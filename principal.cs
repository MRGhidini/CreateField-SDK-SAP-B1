using System;
using System.Collections.Generic;
using System.Text;
using SAPbobsCOM;
using System.Windows.Forms;

namespace CreateField
{
    class principal
    {
        public Company ocompany = new Company();
        public Int32 dentry;

        public principal(Company _ocompany)
        {
            ocompany = _ocompany;
        }

        #region Cria Tabelas e Campos
        
        public Int32 CriaTabela(string Nome, String Descricao, BoUTBTableType tp)
        {
            Int32 i = 0;
            UserTablesMD oUserTablesMD;
            oUserTablesMD = (UserTablesMD)ocompany.GetBusinessObject(BoObjectTypes.oUserTables);
            oUserTablesMD.TableName = Nome;
            oUserTablesMD.TableDescription = Descricao;
            oUserTablesMD.TableType = tp;

            i = oUserTablesMD.Add();

            return i;
        }

        public Int32 CriaCampo(String Nome, string descricao, int tamanho, BoFieldTypes fldtype, BoFldSubTypes fldsubtype, string tabela, string tabelalink = "", Boolean validvalue = false, string ValidValue1 = "", string ValidDscr1 = "", string ValidValue2 = "", string ValidDscr2 = "", string ValidValue3 = "", string ValidDscr3 = "", string ValidValue4 = "", string ValidDscr4 = "", string ValidValue5 = "", string ValidDscr5 = "")
        {

            Int32 i = 0;
            try
            {
                UserFieldsMD oUserFieldsMD;
                oUserFieldsMD = (UserFieldsMD)ocompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.Name = Nome;
                oUserFieldsMD.Type = fldtype;
                oUserFieldsMD.Description = descricao;
                oUserFieldsMD.Size = tamanho;
                oUserFieldsMD.SubType = fldsubtype;
                oUserFieldsMD.TableName = tabela;
                oUserFieldsMD.LinkedTable = tabelalink;

                if (validvalue == true)
                {
                    oUserFieldsMD.ValidValues.Value = ValidValue1;
                    oUserFieldsMD.ValidValues.Description = ValidDscr1;
                    oUserFieldsMD.ValidValues.Add();

                    oUserFieldsMD.ValidValues.Value = ValidValue2;
                    oUserFieldsMD.ValidValues.Description = ValidDscr2;
                    oUserFieldsMD.ValidValues.Add();

                    oUserFieldsMD.ValidValues.Value = ValidValue3;
                    oUserFieldsMD.ValidValues.Description = ValidDscr3;
                    oUserFieldsMD.ValidValues.Add();

                    if (ValidValue4 != "")
                    {
                        oUserFieldsMD.ValidValues.Value = ValidValue4;
                        oUserFieldsMD.ValidValues.Description = ValidDscr4;
                        oUserFieldsMD.ValidValues.Add();
                    }

                    if (ValidValue5 != "")
                    {
                        oUserFieldsMD.ValidValues.Value = ValidValue5;
                        oUserFieldsMD.ValidValues.Description = ValidDscr5;
                        oUserFieldsMD.ValidValues.Add();
                    }
                }

                i = oUserFieldsMD.Add();

                //if (i != 0)
                //    throw new Exception(ocompany.GetLastErrorDescription());

                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return i;
            }
        }

        #endregion 
    }
}