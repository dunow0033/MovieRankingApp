using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Model.Tree;
using Microsoft.EntityFrameworkCore;
using MovieRanking.Models;

namespace MovieRanking.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemModelsController : ControllerBase
    {
        private readonly MovieDBContext _context;

        public ItemModelsController(MovieDBContext context)
        {
            _context = context;
        }

        // GET: ItemModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemModel>>> GetItems()
        {
            //System.Threading.Thread.Sleep(2000);
            return await _context.Items.ToListAsync();

            //return await _context.Items.Where(i => i.ItemType == itemType).ToArray();
        }

        // GET: api/ItemModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetItemModel(int id)
        {
            var itemModel = await _context.Items.FindAsync(id);

            if (itemModel == null)
            {
                return NotFound();
            }

            return itemModel;
        }

        // PUT: api/ItemModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutItemModel(int id, ItemModel itemModel)
        //{
        //    if (id != itemModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(itemModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/ItemModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemModel>> PostItemModel(List<ItemModel> itemModels)
        {
            foreach (var itemModel in itemModels)
            {
                _context.Items.Add(itemModel);
            }
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/ItemModels/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteItemModel(int id)
    //    {
    //        var itemModel = await _context.Items.FindAsync(id);
    //        if (itemModel == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Items.Remove(itemModel);
    //        await _context.SaveChangesAsync();

    //        return NoContent();
    //    }

    //    private bool ItemModelExists(int id)
    //    {
    //        return _context.Items.Any(e => e.Id == id);
    //    }
    }
}
