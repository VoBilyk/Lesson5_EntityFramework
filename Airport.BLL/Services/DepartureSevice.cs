﻿using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Entities;
using Airport.Shared.DTO;


namespace Airport.BLL.Services
{
    public class DepartureService : IDepartureService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public DepartureService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public DepartureDto Get(Guid id)
        {
            return mapper.Map<Departure, DepartureDto>(db.DepartureRepository.Get(id));
        }

        public List<DepartureDto> GetAll()
        {
            return mapper.Map<List<Departure>, List<DepartureDto>>(db.DepartureRepository.GetAll());
        }

        public DepartureDto Create(DepartureDto departureDto)
        {
            var departure = mapper.Map<DepartureDto, Departure>(departureDto);
            departure.Id = Guid.NewGuid();
            departure.Crew = db.CrewRepositiry.Get(departureDto.CrewId);
            departure.Airplane = db.AeroplaneRepository.Get(departureDto.AirplaneId);

            db.DepartureRepository.Create(departure);
            db.SaveChanges();

            return mapper.Map<Departure, DepartureDto>(departure);
        }

        public DepartureDto Update(Guid id, DepartureDto departureDto)
        {
            var departure = mapper.Map<DepartureDto, Departure>(departureDto);
            departure.Id = id;
            departure.Airplane = db.AeroplaneRepository.Get(departureDto.AirplaneId);
            departure.Crew = db.CrewRepositiry.Get(departureDto.CrewId);

            db.DepartureRepository.Update(departure);
            db.SaveChanges();

            return mapper.Map<Departure, DepartureDto>(departure);
        }

        public void Delete(Guid id)
        {
            db.DepartureRepository.Delete(id);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            db.DepartureRepository.Delete();
            db.SaveChanges();
        }
    }
}