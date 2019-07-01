﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beamity.Application.DTOs;
using Beamity.Application.DTOs.ContentDTOs;
using Beamity.Application.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Beamity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }
        [HttpGet("{id}")]
        public ReadContentDTO GetContent(EntityDTO input)
        {
            try
            {
                var content = _contentService.GetContent(input);
                return content;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public List<ReadContentDTO> GetAllContents()
        {
            try
            {
                var contents = _contentService.GetAllContents();
                return contents;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public IActionResult CreateBeacon(CreateContentDTO input)
        {
            try
            {
                _contentService.CrateContent(input);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut]
        public IActionResult UpdateBeacon(UpdateContentDTO input)
        {
            try
            {
                _contentService.UpdateContent(input);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete]
        public IActionResult DeleteBeacon(DeleteContentDTO input)
        {
            try
            {
                _contentService.DeleteContent(input);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}