using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03___PROJETO_01
{
    internal class FuncBLL
    {
        public static void ValidarDados(Funcionario umFuncionario)
        {
            Erro.TemErro = false;

            //faz a validação da Base
            if (umFuncionario.Nome.Length == 0)
            {
                Erro.Mensagem = "O campo Nome é obrigatório!";
                return;
            }

            if (umFuncionario.QtdHoras.Length == 0)
            {
                Erro.Mensagem = "O campo Quantidade De Horas é obrigatório!";
                return;
            }
            else
            {
                try
                {
                    float.Parse(umFuncionario.QtdHoras);
                }
                catch
                {
                    Erro.Mensagem = "O campo Quantidade de Horas deve ser Númerico!";
                    return;
                }
                if (float.Parse(umFuncionario.QtdHoras) <= 0)
                {
                    Erro.Mensagem = "O campo Quantidade de Horas  deve ser maior que 0 !";
                    return;
                }
                if (umFuncionario.HoraTrabalhada.Length == 0)
                {
                    Erro.Mensagem = "O campo Horas Trabalhadas é obrigatório!";
                    return;
                }
                else
                {
                    try
                    {
                        float.Parse(umFuncionario.HoraTrabalhada);
                    }
                    catch
                    {
                        Erro.Mensagem = "O campo Horas Trabalhadas  deve ser Númerico!";
                        return;
                    }
                    if (float.Parse(umFuncionario.HoraTrabalhada) <= 0)
                    {
                        Erro.Mensagem = "O campo Horas Trabalhadas  deve ser maior que 0 !";
                        return;
                    }
                }
            }
        }
    }
}
