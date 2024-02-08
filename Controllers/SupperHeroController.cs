using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTutoriala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupperHeroController : ControllerBase
    {
        private static List<SupperHero> heroes = new List<SupperHero>
        {
        
        
        new SupperHero
        {
            Id= 1,
            Name ="spider Man",
            FirstName ="Peter",
            LastName= "Parker",
            Place= "New York City",
            DateAdded= new DateTime(2024,01,16),
            DateModified = null
        },
        new SupperHero
        {
             Id= 2,
            Name ="Iron Man",
            FirstName ="Omer",
            LastName= "Jack",
            Place= "Baghdad",
            DateAdded= new DateTime(2023,01,16),
            DateModified = null
        }


      };

      private readonly IMapper _mapper;
      public SupperHeroController(IMapper mapper)
      {
        _mapper = mapper;
      }
       [HttpGet]
       public ActionResult<List<SupperHero>> GetHeroes()
       {
        
        return Ok(heroes.Select(hero => _mapper.Map<SupperHeroDto>(hero)));
       } 
        [HttpPost]
       public ActionResult<List<SupperHero>> AddHeroes(SupperHeroDto newHero)
       {
        var hero = _mapper.Map<SupperHero>(newHero);
        heroes.Add(hero);
        return Ok(heroes.Select(hero => _mapper.Map<SupperHeroDto>(hero)));
       } 

       
    }
}