
using HerenciaPolimorfismo;

Vivienda unaVivienda = new Vivienda(
    "Gral. Flores 1234",
    200,
    150000,
    4
);

Comercial unaComercial = new Comercial(
    "Gral. Flores 4321",
    2500,
    500000,
    5
);

List<Inmueble> lista = new List<Inmueble>();
lista.Add(unaVivienda);
lista.Add(unaComercial);

foreach (Inmueble inmu in lista)
{

    Console.WriteLine(inmu.Direccion);
    Console.WriteLine(inmu.Precio);
    Console.WriteLine(inmu.SuperficieEnM2);
    Console.WriteLine(inmu.Mostrar());
}

