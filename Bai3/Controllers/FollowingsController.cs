using Bai3.DTOs;
using Bai3.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Bai3.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext db;
        public FollowingsController (){

            db = new ApplicationDbContext();

        }
        // GET: Followings
        [HttpPost]
        
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (db.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
            {
                return BadRequest("Following Resut");
            }


            var following = new Following
            {
                FolloweeId = followingDto.FolloweeId,
                FollowerId = userId
            };
            db.Followings.Add(following);   
            db.SaveChanges();   
            return Ok();
        }
    }
}