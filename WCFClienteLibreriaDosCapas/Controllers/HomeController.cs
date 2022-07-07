using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClienteLibreriaDosCapas.ServiceLibreria;

namespace WCFClienteLibreriaDosCapas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient()) 
                {
                    er = wcf.Obtener();
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    List<EntLibreria> ls = er.LibrosLista.ToList();
                    return View(ls);
                }

            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                List<EntLibreria> ls = new List<EntLibreria>();
                return View(ls);
            }

        }
        [HttpGet]
        public ActionResult Create() 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.ObtenerC();
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    List<EntCategoria> ls = er.ListaCategoria.ToList();
                    ViewBag.Categoria = new SelectList(ls, "IdC", "NombreC");
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                //List<EntLibreria> ls = new List<EntLibreria>();
                return RedirectToAction("Index");
            }

        }
        public ActionResult Create( EntLibreria l) 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.ValidarRepetido(l);
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    er = wcf.Agregar(l);
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    TempData["resu"] = "Se agregó" +l.Titulo;
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.ObtenerC();
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    List<EntCategoria> ls = er.ListaCategoria.ToList();
                    ViewBag.Categoria = new SelectList(ls, "IdC", "NombreC");
                    
                }
                TempData["error"] = ex.Message;
                return View("Create");

            }
        }
        [HttpGet]
        public ActionResult Edit(int id) 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    EntLibreria l = wcf.IdObtener(id).EntLibre;
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    //List<EntCategoria> list = er.ListaCategoria.ToList();
                    List<EntCategoria> list = wcf.ObtenerC().ListaCategoria.ToList();
                    ViewBag.Categoria = new SelectList(list, "IdC", "NombreC",l.Categoria);
                    return View("Edit",l);
                }

            }
            catch (Exception ex)
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.ObtenerC();
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    List<EntCategoria> ls = er.ListaCategoria.ToList();
                    ViewBag.Categoria = new SelectList(ls, "IdC", "NombreC");

                }
                TempData["error"] = ex.Message;
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(EntLibreria l) 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.Actualizar(l);
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    TempData["resu"] = "Se Actualizo a: " + l.Titulo;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("Edit");
            }


        }
        public ActionResult Delete(int id) 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.Eliminar(id);
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    TempData["resu"] = "Registro Eliminado";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("Index");
            }
        }
        public ActionResult Buscar(string Valor) 
        {
            EntRespuesta er = new EntRespuesta();
            try
            {
                using (ServiceLibreriaClient wcf = new ServiceLibreriaClient())
                {
                    er = wcf.Buscar(Valor);
                    if (er.Error == true)
                    {
                        throw new Exception(er.Msj);
                    }
                    List<EntLibreria> ls = er.LibrosLista.ToList();
                    return View("Index",ls);
                }

            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("Index");
            }
        }
    }
}