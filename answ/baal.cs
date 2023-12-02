using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answ
{
    public static class baal
    {
        public static List<string> Mess;
       

        static baal()
        {
            Mess = new List<string>()
            {
                "Вы ответили не на один вопрос!",
                "Вы ответили на половину вопросов!",
                "Вы ответили почти на все вопросы!",
                "Вы ответили на все вопросы! Молодцы!"
            };
        }
    }
}
