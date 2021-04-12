using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore
{
    // Program과 Startup을 구분해서 사용하는 이유
    // Program : 거시적인 설정 (HTTP 서버, IIS 사용 여부 등 거의 바뀌지 않음)
    // Startup : 미들웨어 설정, 종속성 주입 등 필요에 따라 추가/수정 빈번함
    public class Program
    {
        public static void Main(string[] args)
        {
            // 3) IHost 만들기
            // 4) 구동(Run) => Listen 시작
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // 1) 각종 옵션 세팅
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // 2) Startup 클래스 지정
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
