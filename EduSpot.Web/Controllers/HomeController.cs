using EduSpot.Web.DataAccess.Services.IServices;
using EduSpot.Web.Models;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
namespace EduSpot.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUniversityService _universityService;
        private readonly IMajorService _majorService;
        private readonly IMaterialService _materialService;
        private readonly ISummaryService _SummaryService;
        private readonly IChapterService _ChapterService;
        private readonly ILectureService _LectureService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,
            IUniversityService universityService, IMajorService majorService,
            IMaterialService materialService, ISummaryService summaryService,
            IChapterService chapterService, ILectureService lectureService )
        {
            _logger = logger;
            _majorService = majorService;
            _universityService = universityService;
            _materialService = materialService;
            _SummaryService = summaryService;
            _ChapterService = chapterService;
            _LectureService = lectureService;
        }
        [Authorize]
        public async Task<IActionResult> UniversityIndex()
        {
            List<UniversityDto?> List = new List<UniversityDto?>();
            ResponseDto? response = await _universityService.GetAllUniversityAsync();
            if (response != null && response.IsSuccess)
            {
                List = JsonConvert.DeserializeObject<List<UniversityDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(List);
        }
        [Authorize]
        public async Task<IActionResult> MajorIndex(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                List<MajorDto?> List = new();
                ResponseDto? response = await _majorService.GetAllMajorAsync();
                if (response != null && response.IsSuccess)
                {
                    List = JsonConvert.DeserializeObject<List<MajorDto?>>(Convert.ToString(response.Result))
                           .Where(u => u.UniversityId == id).ToList();
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View(List);
            }
        }
        [Authorize]
        public async Task<IActionResult> MaterialIndex(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                List<MaterialDto?> List = new();
                ResponseDto? response = await _materialService.GetAllMaterialAsync();
                if (response != null && response.IsSuccess)
                {
                    List = JsonConvert.DeserializeObject<List<MaterialDto?>>(Convert.ToString(response.Result))
                           .Where(u => u.MajorId == id).ToList();

                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View(List);
            }
        }
        [Authorize]
        public async Task<IActionResult> SummaryIndex(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                List<SummaryDto?> List = new List<SummaryDto?>();
                ResponseDto? response = await _SummaryService.GetAllSummaryAsync();

                if (response != null && response.IsSuccess)
                {
                    List = JsonConvert.DeserializeObject<List<SummaryDto?>>(Convert.ToString(response.Result))
                           .Where(u => u.MaterialId == id).ToList();
                    
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View(List);
            }
        }
        [Authorize]
        public async Task<IActionResult> ChapterIndex(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                List<ChapterDto?> List = new List<ChapterDto?>();
                ResponseDto? response = await _ChapterService.GetAllChapterAsync();
                if (response != null && response.IsSuccess)
                {
                    List = JsonConvert.DeserializeObject<List<ChapterDto?>>(Convert.ToString(response.Result))
                           .Where(u => u.MaterialId == id).ToList();

                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View(List);
            }
        }
        [Authorize]
        public async Task<IActionResult> LectureIndex(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                List<LectureDto?> List = new List<LectureDto?>();
                ResponseDto? response = await _LectureService.GetAllLectureAsync();

                if (response != null && response.IsSuccess)
                {
                    List = JsonConvert.DeserializeObject<List<LectureDto?>>(Convert.ToString(response.Result))
                           .Where(u => u.MaterialId == id).ToList();

                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View(List);
            }
        }
 

       public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
