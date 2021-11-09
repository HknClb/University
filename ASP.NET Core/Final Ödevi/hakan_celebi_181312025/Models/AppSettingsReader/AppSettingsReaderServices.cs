using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hakan_celebi_181312025.Models.AppSettingsReader
{
    public static class AppSettingsReaderExtension
    {
        public static IServiceCollection RegisterAppSettingsReader(this IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<User1Section>(Configuration.GetSection("User1"));
            services.Configure<User2Section>(Configuration.GetSection("User2"));
            services.Configure<User3Section>(Configuration.GetSection("User3"));
            services.Configure<User4Section>(Configuration.GetSection("User4"));
            services.Configure<User5Section>(Configuration.GetSection("User5"));
            services.Configure<User6Section>(Configuration.GetSection("User6"));
            services.Configure<User7Section>(Configuration.GetSection("User7"));
            services.Configure<User8Section>(Configuration.GetSection("User8"));
            services.Configure<User9Section>(Configuration.GetSection("User9"));
            services.AddSingleton<IAppSettingsReaderServices, AppSettingsReaderServices>();
            return services;
        }
    }

    public class AppSettingsReaderServices : IAppSettingsReaderServices
    {
        private readonly User1Section _user1Section;
        private readonly User2Section _user2Section;
        private readonly User3Section _user3Section;
        private readonly User4Section _user4Section;
        private readonly User5Section _user5Section;
        private readonly User6Section _user6Section;
        private readonly User7Section _user7Section;
        private readonly User8Section _user8Section;
        private readonly User9Section _user9Section;
        public AppSettingsReaderServices(IOptions<User1Section> iOptinsUser1, IOptions<User2Section> iOptinsUser2, IOptions<User3Section> iOptinsUser3, IOptions<User4Section> iOptinsUser4, IOptions<User5Section> iOptinsUser5,
            IOptions<User6Section> iOptinsUser6, IOptions<User7Section> iOptinsUser7, IOptions<User8Section> iOptinsUser8, IOptions<User9Section> iOptinsUser9)
        {
            _user1Section = iOptinsUser1.Value;
            _user2Section = iOptinsUser2.Value;
            _user3Section = iOptinsUser3.Value;
            _user4Section = iOptinsUser4.Value;
            _user5Section = iOptinsUser5.Value;
            _user6Section = iOptinsUser6.Value;
            _user7Section = iOptinsUser7.Value;
            _user8Section = iOptinsUser8.Value;
            _user9Section = iOptinsUser9.Value;
        }
        public User1Section user1Section { get => _user1Section; }
        public User2Section user2Section { get => _user2Section; }
        public User3Section user3Section { get => _user3Section; }
        public User4Section user4Section { get => _user4Section; }
        public User5Section user5Section { get => _user5Section; }
        public User6Section user6Section { get => _user6Section; }
        public User7Section user7Section { get => _user7Section; }
        public User8Section user8Section { get => _user8Section; }
        public User9Section user9Section { get => _user9Section; }
    }

    public interface IAppSettingsReaderServices
    {
        public User1Section user1Section { get; }
        public User2Section user2Section { get; }
        public User3Section user3Section { get; }
        public User4Section user4Section { get; }
        public User5Section user5Section { get; }
        public User6Section user6Section { get; }
        public User7Section user7Section { get; }
        public User8Section user8Section { get; }
        public User9Section user9Section { get; }
    }
    public class User1Section
    {
        public User user
        {
            get {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User2Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User3Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User4Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User5Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User6Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User7Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User8Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }

    public class User9Section
    {
        public User user
        {
            get
            {
                User u = new User();
                u.Username = Username;
                u.Password = Password;
                u.Authority = Authority;
                return u;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}
