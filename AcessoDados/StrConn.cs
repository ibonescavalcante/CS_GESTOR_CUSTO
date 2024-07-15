using System;
using System.Collections.Generic;
using System.Text;

namespace AcessoDados
{
   public class StrConn
    {
        public struct StringConexao
        {
            #region BASE
            public static string StrConexao = carregaLogE("Connexao.ini");
           // public static string StrConexao = "Data Source=DESKTOP-PC;Initial Catalog=dbCustos;User ID=sa;Password=123";
            #endregion

        }

        private static string carregaLogE(string nomeArquivo)
        {
            string caminho;
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string directory = System.IO.Path.GetDirectoryName(path);
            caminho = directory.Replace(@"file:\", "") + @"\" + nomeArquivo;
            string Conn = "";

            //  System.Diagnostics.Debug.Print(caminho);

            if (System.IO.File.Exists(caminho))
            {
                string[] text = System.IO.File.ReadAllLines(caminho);

                foreach (string line in text)
                {
                    string lines = (line);
                    if (lines.Length != 0)
                    {
                        //   System.Diagnostics.Debug.Print(lines);
                        Conn = Conn + lines;
                    }
                }
                Conn = Conn.Replace("[", "");
                return Conn.Replace("]", "");
            }
            return null;

        }
    }
}
