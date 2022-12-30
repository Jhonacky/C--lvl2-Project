using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria, A.IdMarca, A.Id from Articulos A, Categorias C, Marcas M where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Tipo();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Tipo();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Id = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('" + nuevo.CodArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Marca.Id + ", " + nuevo.Categoria.Id + ", '" + nuevo.UrlImagen + "', " + nuevo.Precio + ")");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = '"+ modificado.CodArticulo +"', Nombre = '"+ modificado.Nombre +"', Descripcion = '"+ modificado.Descripcion +"', IdMarca = "+ modificado.Marca.Id +", IdCategoria = "+ modificado.Categoria.Id +", ImagenUrl = '"+ modificado.UrlImagen +"', Precio = " + modificado.Precio + "where id = " + modificado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar (int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar (string campo, string criterio, string marca, string categoria, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria, A.IdMarca, A.Id from Articulos A, Categorias C, Marcas M where A.IdMarca = M.Id and A.IdCategoria = C.Id ";
            switch (campo)
                {
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Termina con":
                                consulta += "And Nombre like '%"+ filtro +"'";
                                break;
                            case "Empieza con":
                                consulta += "And Nombre like '" + filtro + "%'";
                                break;
                            case "Contiene":
                                consulta += "And Nombre like '%"+ filtro +"%'";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Termina con":
                                consulta += "And A.Descripcion like '%" + filtro + "'";
                                break;
                            case "Empieza con":
                                consulta += "And A.Descripcion like '" + filtro + "%'";
                                break;
                            case "Contiene":
                                consulta += "And A.Descripcion like '%" + filtro + "%'";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "And Precio < " + filtro;
                                break;
                            case "Menor a":
                                consulta += "And Precio > " + filtro;
                                break;
                            case "Igual a":
                                consulta += "And Precio = " + filtro;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

                if (marca != "Todas")
                {
                    consulta += " And M.Descripcion = '" + marca + "' ";
                }

                if (categoria != "Todas")
                {
                    consulta += " And C.Descripcion = '" + categoria + "'";
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Tipo();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Tipo();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Id = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
