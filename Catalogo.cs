using System.Collections.Generic;
using System.Linq;
using FordApp.Pages;

namespace FordApp
{
    // Fuente única de datos del prototipo (precios ficticios)
    public static class Catalogo
    {
        public static readonly List<Vehiculo> Todos = new List<Vehiculo>
        {
            new Vehiculo("Ford Puma Gen-E", "SUV compacto eléctrico", 28900, "/Assets/Images/puma.jpg"),
            new Vehiculo("Ford Explorer Eléctrico", "SUV familiar eléctrico", 48900, "/Assets/Images/explorer.jpg"),
            new Vehiculo("Ford Capri", "SUV coupé eléctrico", 45900, "/Assets/Images/capri.jpg"),
            new Vehiculo("Ford Mustang Mach-E", "SUV deportivo eléctrico", 52900, "/Assets/Images/mach-e.jpg"),
            new Vehiculo("Ford Kuga", "SUV híbrido enchufable", 38900, "/Assets/Images/kuga.jpg"),
            new Vehiculo("Ford Ranger", "Pick-up", 41900, "/Assets/Images/ranger.jpg"),
        };

        public static IEnumerable<Vehiculo> Novedades => Todos.Take(3);

        public static IEnumerable<Vehiculo> MejoresPrecios => Todos.OrderBy(v => v.Precio).Take(3);
    }
}