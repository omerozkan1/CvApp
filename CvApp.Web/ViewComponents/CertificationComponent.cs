using AutoMapper;
using CvApp.Business.Interfaces;
using CvApp.DTO.DTOs.CertificationDtos;
using CvApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CvApp.Web.ViewComponents
{
    public class CertificationComponent : ViewComponent
    {
        private readonly IGenericService<Certification> _genericCertificationService;
        private readonly IMapper _mapper;

        public CertificationComponent(IGenericService<Certification> genericCertificationService, IMapper mapper)
        {
            _genericCertificationService = genericCertificationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericCertificationService.GetAll()));
        }
    }
}
