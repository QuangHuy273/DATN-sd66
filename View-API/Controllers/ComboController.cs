//using API.Controllers;
using API.Data;
using API.HeThong;
using API.Models;
using API.Models.DTO;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using View_API.Controllers;

namespace ViewAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComboController : BaseController<Combo, ComboDTO, string>
    {
        public ComboController(IRepository<Combo, string> repository, DBAppContext context, IMapper mapper, XulyId xulyId)
            : base(repository, context, mapper, xulyId)
        {
            _useXulyIdGeneration = true;
            _idPrefix = "CB";
            _idColumnName = "Id";
        }
    }
}

