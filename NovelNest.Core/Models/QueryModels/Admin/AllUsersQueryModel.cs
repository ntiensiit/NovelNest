namespace NovelNest.Core.Models.QueryModels.Admin
{
    using NovelNest.Core.Enums;
    using System.ComponentModel.DataAnnotations;

    public class AllUsersQueryModel
    {
        public int UsersPerPage { get; } = 8;
        public int CurrentPage { get; set; } = 1;

        [Display(Name = "Search")]
        public string SearchTerm { get; set; } = null!;

        [Display(Name = "Role")]
        public UserRoleStatus RoleStatus { get; set; }

        public int TotalUsersCount { get; set; }

        public IEnumerable<UserServiceModel> Users { get; set; } = new HashSet<UserServiceModel>();
    }
}