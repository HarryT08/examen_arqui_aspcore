﻿namespace Backend.Models
{
    public class TareaModel
    {
        public int idTarea { get; set; }
        public string? descripcion { get; set; }
        public string? nombre { get; set; }
        public int prioridad { get; set; }
        public DateTime entrega { get; set; }
        public int idEstado { get; set; }
    }
}
