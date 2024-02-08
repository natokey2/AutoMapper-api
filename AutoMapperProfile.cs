using AutoMapper;

public class AutoMapperProfile:Profile
{
    public AutoMapperProfile()
    {
        CreateMap<SupperHero, SupperHeroDto>();
         CreateMap<SupperHeroDto, SupperHero>();
    }
}