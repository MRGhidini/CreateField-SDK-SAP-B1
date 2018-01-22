using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Settings
{
    const string userRoot = "HKEY_CURRENT_USER\\SOFTWARE";
    const string subkey = "CreateField";
    const string keyName = userRoot + "\\" + subkey;

    public static RegistryKey RegistryKeyOpen = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CreateField\");
    public static RegistryKey registrykeyCreate = Registry.CurrentUser.CreateSubKey(keyName);

    public static void VerifyRegistro()
    {
        if (RegistryKeyOpen == null)
        {
            Registry.SetValue(keyName, "Server", "ServerNameSQL");
            Registry.SetValue(keyName, "BaseName", "HANA");
            Registry.SetValue(keyName, "SQLType", "HANA");
            Registry.SetValue(keyName, "UserDB", "UserDB");
            Registry.SetValue(keyName, "PwDB", "PWDB");
            Registry.SetValue(keyName, "UserSAP", "manager");
            Registry.SetValue(keyName, "PwSAP", "PWSAP");
            Registry.SetValue(keyName, "LicenServer", "localhost:30000");
            registrykeyCreate.Close();

        }
    }

    public static string LerRegistro(string Regs)
    {
            var Server = RegistryKeyOpen.GetValue(Regs).ToString();
            return Server;
    }

    public static void GravarRegistro(string Regs, string valor)
    {
        Registry.SetValue(keyName, Regs, valor);
        registrykeyCreate.Close();
    }
}
