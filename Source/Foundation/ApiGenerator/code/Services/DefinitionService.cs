using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;
using SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces;
using System.Collections.Generic;

namespace SitecoreMaster.Foundation.ApiGenerator.Services
{
    public class DefinitionService : IDefinitionService
    {
        private readonly IDefinitionRepository _definitionRepo;

        public DefinitionService(IDefinitionRepository definitionRepository)
        {
            _definitionRepo = definitionRepository;
        }

        public IEnumerable<IDefinition> GetAll()
        {
            IEnumerable<IDefinition> results = _definitionRepo.GetAll();

            return results;
        }

        public IDefinition GetByName(string name)
        {
            IDefinition item = _definitionRepo.GetByName(name);

            return item;
        }
    }
}