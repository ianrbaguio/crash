﻿using Crash.Queries;
using Crash.Models.Dtos;
using MediatR;
using Crash.Repositories.IRepositories;
using AutoMapper;

namespace Crash.Query.Handlers
{
   public class GetAccidentsQueryHandler : IRequestHandler<GetAccidentsQuery, List<AccidentDto>>
   {
        private readonly IAccidentRepository _accidentRepository;
        private readonly IMapper _mapper;
        public GetAccidentsQueryHandler(IMapper mapper, IAccidentRepository accidentRepository)
        {
            _accidentRepository = accidentRepository;
            _mapper = mapper;
         }

      public async Task<List<AccidentDto>> Handle(GetAccidentsQuery query, CancellationToken cancellationToken)

      {
         List<AccidentDto> data = new List<AccidentDto>();

         AccidentDto accident1 = new AccidentDto() { 
            AccidentDate = new DateTime(), 
            Location = "Edmonton, AB",
            Daylight = "Sunny",
            };

         AccidentDto accident2 = new AccidentDto()
         {
            AccidentDate = new DateTime(),
            Location = "Spruce Grove, AB",
            Daylight = "Rainy",
         };

         data.Add(accident1);
         data.Add(accident2);

            var accidents = await _accidentRepository.GetAccidentListAsync();

            return _mapper.Map<List<AccidentDto>>(accidents);
        }
   }
}
