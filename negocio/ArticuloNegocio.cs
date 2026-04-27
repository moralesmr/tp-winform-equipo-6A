using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocio
{
    public class ArticuloNegocio
    {


        public void agregar(Articulo a)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + a.CodArticulo + "','" + a.Nombre + "', '" + a.Descripcion + "', @idMarca, @idCategoria," + a.Precio + ")");
                datos.setearParametros("@IdMarca", a.Marca.Id);
                datos.setearParametros("@IdCategoria", a.Categoria.Id);
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codArticulo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @precio where Id = @id");
                datos.setearParametros("@codArticulo", articulo.CodArticulo);
                datos.setearParametros("@nombre", articulo.Nombre);
                datos.setearParametros("@descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@precio", articulo.Precio);
                datos.setearParametros("@Id", articulo.Id);
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

        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT A.id, A.Codigo, A.Nombre, A.Descripcion, M.id, M.Descripcion AS Marca, C.id, C.Descripcion AS Categoria, A.Precio\r\nFROM ARTICULOS A\r\nINNER JOIN MARCAS M ON A.idMarca = M.id\r\nINNER JOIN CATEGORIAS C ON A.idCategoria = C.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["id"];

                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    aux.Marca = new Marca();

                    aux.Marca.Id = (int)datos.Lector["id"]; //cambiar por idMarca
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"].ToString();

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["id"]; //cambiar por idCategoria
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"].ToString();
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //if(!(lector["UrlImagen"] is DBNull ))
                    //aux.UrlImagen = (string)datos.Lector["UrlImagen"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setearParametros("@id", id);
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


























        public List<Articulo> filtrar(string campo, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"SELECT A.Codigo, A.Nombre, A.Descripcion, 
                                    M.Descripcion AS Marca, 
                                    C.Descripcion AS Categoria, 
                                    A.Precio
                                    FROM ARTICULOS A
                                    INNER JOIN MARCAS M ON A.idMarca = M.id
                                    INNER JOIN CATEGORIAS C ON A.idCategoria = C.id
                                    WHERE ";

                switch (campo)
                {
                    case "Nombre":
                        consulta += "A.Nombre LIKE '%" + filtro + "%'";
                        break;
        
                    case "Marca":
                        consulta += "M.Descripcion LIKE '%" + filtro + "%'";
                        break;
        
                    case "Categoria":
                        consulta += "C.Descripcion LIKE '%" + filtro + "%'";
                        break;
        
                    case "Codigo":
                        consulta += "A.Codigo LIKE '%" + filtro + "%'";
                        break;
        
                    case "Precio":
                        decimal precio;
        
                        if (decimal.TryParse(filtro, out precio))
                        {
                            consulta += "A.Precio = " + precio;
                        }
                        else
                        {
                            throw new Exception("El valor ingresado para Precio no es válido.");
                        }
        
                        break;
                }

                datos.setConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
        
                    aux.CodArticulo = datos.Lector["Codigo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
        
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = datos.Lector["Marca"].ToString();
        
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = datos.Lector["Categoria"].ToString();
        
                    aux.Precio = (decimal)datos.Lector["Precio"];
        
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


