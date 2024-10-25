using HandyApp.HandymanApplicationCommon;
using HandyApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.FirstInstall
{
    public class ServiceDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Service, Guid> _serviceRepository;

        public ServiceDataSeederContributor(IRepository<Service, Guid> serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _serviceRepository.GetCountAsync() <= 0)
            {
                // Load the embedded resource
                var assembly = typeof(ServiceDataSeederContributor).Assembly;
                var resourceName = "HandyApp.FirstInstall.ServicesInfo.txt";

                using (var stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new StreamReader(stream))
                {
                    var services = new List<Service>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var parts = line.Split(',');
                        var service = new Service
                        {
                            ServiceName = parts[0].Trim(),
                            ServiceCost = int.Parse(parts[1].Trim()),
                            ServiceType = Enum.Parse<ServiceType>(parts[2].Trim())
                        };
                        services.Add(service);
                    }

                    foreach (var service in services)
                    {
                        await _serviceRepository.InsertAsync(service, autoSave: true);
                    }
                }
            }
        }

    }
}
