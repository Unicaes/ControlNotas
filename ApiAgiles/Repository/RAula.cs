using ApiAgiles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAgiles.Repository
{
    public class RAula :ICrudGeneral<Aula>
    {
        private readonly Model1 db = new Model1();
        public Response Delete(int id)
        {
            try
            {
                var user = db.Aula.Find(id);
                if (user == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "No se encontro ningun Aula con el id " + id
                    };
                }
                var resp = db.Aula.Remove(user);
                db.SaveChanges();
                if (resp == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "El Aula no existe"
                    };
                }
                return new Response
                {
                    IsSuccess = true,
                    Result = user,
                    Message = "El Aula ha sido eliminado exitosamente"
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.InnerException.Message
                };
            }
        }

        public Response Get()
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                return new Response
                {
                    IsSuccess = true,
                    Result = db.Aula.ToList(),
                    Message = db.Aula.ToList().Count == 0 ? "No hay Aulas registrados" : ""
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.InnerException.Message
                };
            }
            finally
            {
                db.Configuration.ProxyCreationEnabled = true;
            }
        }

        public Response GetById(int id)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var user = db.Aula.Find(id);
                if (user == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "No se encontro ningun Aula con el id " + id
                    };
                }
                return new Response
                {
                    IsSuccess = true,
                    Result = user
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.InnerException.Message
                };
            }
        }

        public Response Post(Aula item)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Aula.Add(item);
                db.SaveChanges();
                return new Response
                {
                    IsSuccess = true,
                    Result = item
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.InnerException.Message
                };
            }
        }

        public Response Put(Aula item)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                var user = db.Aula.Find(item.Id_Aula);
                if (user == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "No se encontro ningun Aula para actualizar"
                    };
                }
                user.Anio = item.Anio;
                user.Nombre = item.Nombre;
                user.Seccion = item.Seccion;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return new Response
                {
                    IsSuccess = true,
                    Result = user
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.InnerException.Message
                };
            }
        }
    }
}