﻿using System;
using System.IO;
using OfficeOpenXml;
using System.Linq;

namespace Console_1Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ExcelPackage package = new  ExcelPackage())
            {
                using (FileStream rute = File.OpenRead(@"D:\DocumentosOmar\CUENTAS.xlsx"))
                {
                    package.Load(rute);
                }

                ExcelWorksheet cuentas = package.Workbook.Worksheets[0];

                for (int row = 1; ; row++)
                {
                    string fecha = cuentas.Cells[row, 1].Text;

                    if (string.IsNullOrEmpty(fecha))
                    {
                        break;
                    }
                    else
                    {
                        string detalle = cuentas.Cells[row, 2].Text;
                        string e_efectivo = cuentas.Cells[row, 3].Text;
                        string g_efectivo = cuentas.Cells[row, 4].Text;
                        string e_banco = cuentas.Cells[row, 5].Text;
                        string g_banco = cuentas.Cells[row, 6].Text;

                        Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", fecha, detalle, e_efectivo, g_efectivo, e_banco, g_banco);
                       
                    }
                }
                Console.WriteLine("\n");

                ExcelWorksheet cuentas_2 = package.Workbook.Worksheets[1];
                for (int row = 1; ; row++)
                {
                    string fecha = cuentas_2.Cells[row, 1].Text;

                    if (string.IsNullOrEmpty(fecha))
                    {
                        break;
                    }
                    else
                    {
                        string lugar = cuentas_2.Cells[row, 2].Text;
                        string ganancia = cuentas_2.Cells[row, 3].Text;

                        Console.WriteLine("{0} - {1} - {2}", fecha, lugar, ganancia);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
