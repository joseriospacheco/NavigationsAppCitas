namespace Dominio
{    
    public class Cita
    {
        public int Numero { get; set; }
        public required DateOnly Fecha { get; set; }
        public required String Especialidad { get; set; }
        public required string Medico { get; set; }

    }
}
