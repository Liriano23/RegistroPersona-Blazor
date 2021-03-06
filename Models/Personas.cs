﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PrimerRegistroBlazor.Models
{
    public class Personas
    { 
        [Key]
        public int PersonaId { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="Los nombres normalmente no son tan cortos")]
        public string Nombre { get; set; }

        [Required]
        [Phone]
        [MaxLength(10, ErrorMessage ="Telefono muy corto")]
        public string Telefono { get; set; }

        [Required]
        [MinLength(3,ErrorMessage = "Cedula demasiado corta")]
        [MaxLength(11, ErrorMessage = "Ha excedido la cantidad de numeros que contiene una cedula")]
        public string Cedula { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime FechaNacimiento { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
        }

    }
}
