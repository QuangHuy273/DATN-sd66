using API.Data;
using API.HeThong;
using API.Models;
using API.Models.DTO;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace View_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChiTietComboController : BaseController<ChiTietCombo, ChiTietComboDTO, Guid>
    {
        public ChiTietComboController(IRepository<ChiTietCombo, Guid> repository, DBAppContext context, IMapper mapper, XulyId xulyId)
            : base(repository, context, mapper, xulyId)
        {

        }
    }
}
