﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly Lazy<IAgencyRepository> _agency;
        private readonly Lazy<ICityRepository> _city;
        private readonly Lazy<IClientRepository> _client;
        private readonly Lazy<IGarage> _garage;
        private readonly Lazy<IMotorcycle> _motorcycle;
        private readonly Lazy<IPhones> _phones;
        private readonly Lazy<IRent> _rent;

        public IAgencyRepository Agency => _agency.Value;
        public ICityRepository City => _city.Value;
        public IClientRepository Client => _client.Value;
        public IGarage Garage => _garage.Value;
        public IMotorcycle Motorcycle => _motorcycle.Value;
        public IPhones Phones => _phones.Value;
        public IRent Rent => _rent.Value;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;

            _agency = new Lazy<IAgencyRepository>(() => new AgencyRepository(context));
            _city = new Lazy<ICityRepository>(() => new CityRepository(context));
            _client = new Lazy<IClientRepository>(() => new ClientRepository(context));
            _garage = new Lazy<IGarage>(() => new GarageRepository(context));
            _motorcycle = new Lazy<IMotorcycle>(() => new MotorcycleRepository(context));
            _phones = new Lazy<IPhones>(() => new PhonesRepository(context));
            _rent = new Lazy<IRent>(() => new RentRepository(context));
        }

        public void Save() => _context.SaveChanges();

    }
}
