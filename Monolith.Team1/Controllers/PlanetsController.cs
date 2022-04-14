using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Monolith.Team1.Entities;
using Monolith.Team1.Shared;

namespace Monolith.Team1.Controllers {

    [Route("planets")]
    public class PlanetsController : ControllerBase {
        private readonly IsPlanetProvider _service;

        public PlanetsController(IsPlanetProvider service) {
            _service = service;
        }

        public IEnumerable<Planet> Get() {
            return _service.Get();
        }
    }
}