using Microsoft.AspNetCore.Mvc;
using MouseMouvementAPI.Database;
using MouseMouvementAPI.Models;

namespace MouseMouvementAPI.Controllers;

[ApiController]
[Route("api/mousemovement")]
public class MouseMovementController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MouseMovementController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> ReceiveMouseMovements([FromBody] List<MouseMovement> movements)

    {
        if (movements == null || !movements.Any())
        {
            return BadRequest("No movements provided.");
        }

        await _context.MouseMovements.AddRangeAsync(movements);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
