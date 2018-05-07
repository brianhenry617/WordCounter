using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HomeController.Models;

namespace HomeController
{
  public class SentenceController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      <Sentence> all = Sentence.GetAll();
      return View(all);
    }

    [HttpGet("/sentence/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/sentence")]
    public ActionResult Create()
    {
      Sentence newSentence = new Sentence(Request.Form["Sentence"]);

      <Sentence> allSentence = Sentence.GetAll();
      allSentence.Add(newSentence);
      return View("Index", allSentence);
    }

    [HttpPost("sentence/clear")]
    public ActionResult Clear()
    {
      Sentence.ClearAll();
      return View();
    }
  }
}
