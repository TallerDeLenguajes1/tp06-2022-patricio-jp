Console.Clear();
Console.WriteLine("==============================");
Console.WriteLine("====== MÓDULO EMPLEADOS ======");
Console.WriteLine("==============================");
string nombre, apellido, fechaNac, fechaIngreso, sueldo;
char genero, estadoCivil;
DateTime fechaN, fechaI;
double sueldoBasico;
int cargo;

Console.WriteLine("=== Carga de datos ===");
Console.WriteLine("--- Empleado 1 ---");
Console.Write("Ingrese el nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese el apellido: ");
apellido = Console.ReadLine();
Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
fechaNac = Console.ReadLine();
while (!DateTime.TryParse(fechaNac, out fechaN)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaNac = Console.ReadLine();
}
Console.Write("Genero: \nF: Femenino\nM: Masculino\n");
genero = (char) Console.Read();
Console.ReadLine();
Console.Write("Estado civil: \nS: Soltero/a\nC: Casado/a\n");
estadoCivil = (char) Console.Read();
Console.ReadLine();
Console.Write("Ingrese la fecha de ingreso (YYYY-MM-DD): ");
fechaIngreso = Console.ReadLine();
while (!DateTime.TryParse(fechaIngreso, out fechaI)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaIngreso = Console.ReadLine();
}
Console.Write("Ingrese el sueldo básico: $");
sueldo = Console.ReadLine();
while (!Double.TryParse(sueldo, out sueldoBasico)) {
    Console.Write("Error! Ingrese el sueldo correctamente escrito : $");
    sueldo = Console.ReadLine();
}
Console.Write("Cargo: \n0: Auxiliar\n1: Administrativo\n2: Ingeniero\n3: Especialista\n4: Investigador\n");
cargo = Console.Read();
Console.ReadLine();
while (cargo < 0 && cargo > 4) {
    Console.Write("Error! Código de cargo no válido. Ingrese nuevamente: ");
    cargo = Console.Read();
    Console.ReadLine();
}
var listadoCargos = Enum.GetValues(typeof(cargos));
cargos cargoEmpleado = (cargos) listadoCargos.GetValue(cargo - 48);
Empleado empleado1 = new Empleado(nombre, apellido, fechaN, estadoCivil, genero, fechaI, sueldoBasico, cargoEmpleado);


Console.WriteLine("\n--- Empleado 2 ---");
Console.Write("Ingrese el nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese el apellido: ");
apellido = Console.ReadLine();
Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
fechaNac = Console.ReadLine();
while (!DateTime.TryParse(fechaNac, out fechaN)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaNac = Console.ReadLine();
}
Console.Write("Genero: \nF: Femenino\nM: Masculino\n");
genero = (char) Console.Read();
Console.ReadLine();
Console.Write("Estado civil: \nS: Soltero/a\nC: Casado/a\n");
estadoCivil = (char) Console.Read();
Console.ReadLine();
Console.Write("Ingrese la fecha de ingreso (YYYY-MM-DD): ");
fechaIngreso = Console.ReadLine();
while (!DateTime.TryParse(fechaIngreso, out fechaI)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaIngreso = Console.ReadLine();
}
Console.Write("Ingrese el sueldo básico: $");
sueldo = Console.ReadLine();
while (!Double.TryParse(sueldo, out sueldoBasico)) {
    Console.Write("Error! Ingrese el sueldo correctamente escrito : $");
    sueldo = Console.ReadLine();
}
Console.Write("Cargo: \n0: Auxiliar\n1: Administrativo\n2: Ingeniero\n3: Especialista\n4: Investigador\n");
cargo = Console.Read();
Console.ReadLine();
while (cargo < 0 && cargo > 4) {
    Console.Write("Error! Código de cargo no válido. Ingrese nuevamente: ");
    cargo = Console.Read();
    Console.ReadLine();
}
cargoEmpleado = (cargos) listadoCargos.GetValue(cargo - 48);
Empleado empleado2 = new Empleado(nombre, apellido, fechaN, estadoCivil, genero, fechaI, sueldoBasico, cargoEmpleado);


Console.WriteLine("\n--- Empleado 3 ---");
Console.Write("Ingrese el nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese el apellido: ");
apellido = Console.ReadLine();
Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
fechaNac = Console.ReadLine();
while (!DateTime.TryParse(fechaNac, out fechaN)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaNac = Console.ReadLine();
}
Console.Write("Genero: \nF: Femenino\nM: Masculino\n");
genero = (char) Console.Read();
Console.ReadLine();
Console.Write("Estado civil: \nS: Soltero/a\nC: Casado/a\n");
estadoCivil = (char) Console.Read();
Console.ReadLine();
Console.Write("Ingrese la fecha de ingreso (YYYY-MM-DD): ");
fechaIngreso = Console.ReadLine();
while (!DateTime.TryParse(fechaIngreso, out fechaI)) {
    Console.Write("Error! Ingrese una fecha válida (YYYY-MM-DD): ");
    fechaIngreso = Console.ReadLine();
}
Console.Write("Ingrese el sueldo básico: $");
sueldo = Console.ReadLine();
while (!Double.TryParse(sueldo, out sueldoBasico)) {
    Console.Write("Error! Ingrese el sueldo correctamente escrito : $");
    sueldo = Console.ReadLine();
}
Console.Write("Cargo: \n0: Auxiliar\n1: Administrativo\n2: Ingeniero\n3: Especialista\n4: Investigador\n");
cargo = Console.Read();
Console.ReadLine();
while (cargo < 0 && cargo > 4) {
    Console.Write("Error! Código de cargo no válido. Ingrese nuevamente: ");
    cargo = Console.Read();
    Console.ReadLine();
}
cargoEmpleado = (cargos) listadoCargos.GetValue(cargo - 48);
Empleado empleado3 = new Empleado(nombre, apellido, fechaN, estadoCivil, genero, fechaI, sueldoBasico, cargoEmpleado);


Console.Clear();
double sumaSalarios = empleado1.Salario + empleado2.Salario + empleado3.Salario;
Console.WriteLine("\nMonto total de salarios a pagar: $" + sumaSalarios + "\n");



Console.WriteLine("--- Empleado más próximo a jubilarse ---");
Empleado aJubilarse;
if (empleado1.CantAñosJubilarse < empleado2.CantAñosJubilarse) {
    aJubilarse = empleado1;
    if (empleado1.CantAñosJubilarse > empleado3.CantAñosJubilarse) {
        aJubilarse = empleado3;
    }
} else {
    aJubilarse = empleado2;
    if (empleado2.CantAñosJubilarse > empleado3.CantAñosJubilarse) {
        aJubilarse = empleado3;
    }
}
Console.WriteLine(aJubilarse.ToString());