﻿using Microsoft.AspNetCore.Http;
using RealEstateApp.Core.Application.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateApp.Core.Application.ViewModels.Agent
{
    public class EditAgentViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; }

        public string? FotoUrl { get; set; } = " ";

        public IFormFile? Foto { get; set; }

        public string Rol { get; set; } = Roles.Agente.ToString();

        public bool isActive { get; set; } = true;
    }

}
