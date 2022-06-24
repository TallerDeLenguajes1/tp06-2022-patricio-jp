public enum cargos {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado {
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargos Cargo { get => cargo; set => cargo = value; }
    public int Antiguedad {
        get{
            var antiguedad = DateTime.Now.Year - FechaIngreso.Year;
            if (antiguedad > 0) {
                antiguedad -= Convert.ToInt32(DateTime.Now.Date < FechaIngreso.Date.AddYears(antiguedad));
            } else {
                antiguedad = 0;
            }
            return antiguedad;
        }
    }
    public int Edad {
        get{
            var age = DateTime.Now.Year - FechaNacimiento.Year;
            if (age > 0) {
                age -= Convert.ToInt32(DateTime.Now.Date < FechaNacimiento.Date.AddYears(age));
            } else {
                age = 0;
            }
            return age;
        }
    }
    public int CantAñosJubilarse {
        get {
            if (Genero == 'f') {
                return Convert.ToInt32(60 - Edad);
            } else {
                return Convert.ToInt32(65 - Edad);
            }
        }
    }
    public double Salario {
        get {
            double adicional = 0;

            if (Antiguedad > 20) {
                adicional = SueldoBasico * 0.25;
            } else {
                adicional = SueldoBasico * (Antiguedad / 100);
            }

            if (Cargo == cargos.Ingeniero || Cargo == cargos.Especialista) {
                adicional += SueldoBasico * 0.50;
            }

            if (EstadoCivil == 'C' || EstadoCivil == 'c') {
                adicional += 15000;
            }

            return SueldoBasico + adicional;
        }
    }

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double basico, cargos cargo) {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaNacimiento = fechaNac;
        this.EstadoCivil = estadoCivil;
        this.Genero = genero;
        this.FechaIngreso = fechaIngreso;
        this.SueldoBasico = basico;
        this.Cargo = cargo;
    }

    public override string ToString() {
        return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nFecha de nacimiento: " + FechaNacimiento.ToShortDateString() + $"\nEdad: {Edad} años" + "\nEstado Civil: " + EstadoCivil + "\nGenero: " + Genero + "\n\nFecha de ingreso: " + FechaIngreso.ToShortDateString() + $"\nAntiguedad: {Antiguedad} años" + "\nCargo: " + Cargo.ToString() + "\nSueldo básico: $" + SueldoBasico + "\nSalario total: $" + Salario + $"\nCantidad de años para jubilarse: {CantAñosJubilarse} años";
    }
}