using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Unidad_3_Eduardo_Albarizaez.Controllers
{
    public class ArbolController : Controller
    {
        public static void split()
        {
            char[] trims = { '/', '"', '$', ' ', '\'' };
            ArrayList arrText = new ArrayList();


            using (StreamReader archivo = new StreamReader("C:/Users/jealb/OneDrive/Escritorio/datos.txt"))
            {

                while (archivo.Peek() > -1)
                {
                    string linea = archivo.ReadLine().Trim(trims);
                    string[] temp = linea.Split(',');
                    if (temp.Length == 6 && temp[0].Contains("id") == false)
                    {
                        Nodo tempor = new Nodo();
                        tempor.medicina.Id = Convert.ToInt16(temp[0].Trim(trims));
                        tempor.medicina.Nombre = temp[1].Trim(trims);
                        tempor.medicina.Descripcion = temp[2].Trim(trims);
                        tempor.medicina.CasaFarmaceutica = temp[3].Trim(trims);
                        tempor.medicina.Precio = Convert.ToDouble(temp[4].Trim(trims));
                        tempor.medicina.Cantidad = Convert.ToInt16(temp[5].Trim(trims));
                    }
                    else
                    {

                    }
                    if (!String.IsNullOrEmpty(linea))
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
        }
        // GET: Arbol
        public ActionResult Index()
        {
            
            return View();
        }
    }
}