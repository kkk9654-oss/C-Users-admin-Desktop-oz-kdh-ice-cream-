// 잘못된 using 및 불필요한 코드 제거, 올바른 위치로 이동
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oz06kdh_icecream77
{
    internal class Program
    {
        // 플레이어 상태
        static int playerHP = 300;
        static int monsterHP = 70;

        // 행동 이벤트
        public static event Action AttackEvent;
        public static event Action HealEvent;
        public static event Action monsterAttackEvent;

        static void Main(string[] args)
        {
            // 이벤트 핸들러 연결 (예시: 실제 핸들러 메서드 필요)
            // AttackEvent += Attack;
            // HealEvent += Heal;
            // monsterAttackEvent += MonsterAttack;

            Console.WriteLine("=== 전투 게임 시작 ===");

            while (playerHP > 0 && monsterHP > 0)
            {
                Console.WriteLine("\n행동 선택:");
                Console.WriteLine("1. 공격  2. 방어  3. 도망");

                string input = Console.ReadLine();

                // 행동 처리 로직 필요

                Console.WriteLine($"플레이어 HP: {playerHP}, 몬스터 HP: {monsterHP}");
            }

            if (playerHP <= 0)
                Console.WriteLine("패배...");
        }

        // 도망 메서드 위치 및 시그니처 수정
        static void Run()
        {
            Console.WriteLine("도망 시도!");
            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
            {
                Console.WriteLine("도망 성공! 게임 종료");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("도망 실패!");
            }
        }
    }
}