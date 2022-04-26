
namespace Examen_Parcial_3.Data;

public class MySQLConfiguration
{
    public string CadenaConexion { get; }

    public MySQLConfiguration(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }
 
}
