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
    public class NhaCungCapController : BaseController<NhaCungCap, NhaCungCapDTO, Guid>
    {
        public NhaCungCapController(IRepository<NhaCungCap, Guid> repository, DBAppContext context, IMapper mapper, XulyId xulyId) : base(repository, context, mapper, xulyId)
        {
        }
    }
}
