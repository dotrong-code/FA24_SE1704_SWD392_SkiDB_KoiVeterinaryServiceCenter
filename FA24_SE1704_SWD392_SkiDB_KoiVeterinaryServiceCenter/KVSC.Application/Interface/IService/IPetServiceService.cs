﻿using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IPetServiceService
    {
        public Task<Result> CreatePetServiceAsync(AddPetServiceDTO petServiceValidator);
        public Task<Result> GetAllPetServicesAsync();
        public Task<Result> GetPetServiceByIdAsync(Guid id);
        public Task<Result> UpdatePetServiceAsync(Guid id, AddPetServiceDTO addPetService);
        public Task<Result> DeletePetServiceAsync(Guid id);
    }
}
