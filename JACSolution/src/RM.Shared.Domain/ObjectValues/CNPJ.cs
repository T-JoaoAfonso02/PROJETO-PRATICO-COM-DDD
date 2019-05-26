using RM.Shared.Domain.Helpers;
namespace RM.Shared.Domain.ObjectValues
{
    public class CNPJ
    {
        public const int ValorMaxCpf = 14;
        public string Codigo { get; private set; }
        protected CNPJ()
        {
        }
        public CNPJ(string cnpj)
        {
            Codigo = cnpj;
        }
        public static string CnpjLimpo(string cnpj)
        {
            cnpj = TextoHelper.GetNumeros(cnpj);
            if (string.IsNullOrEmpty(cnpj))
                return "";
            while (cnpj.StartsWith("0"))
                cnpj = cnpj.Substring(1);
            return cnpj;
        }
        public string GetCpfCompleto()
        {
            var cnpj = Codigo.ToString();
            if (string.IsNullOrEmpty(cnpj))
                return "";
            while (cnpj.Length < 11)
                cnpj = "0" + cnpj;
            return cnpj;
        }
        public static bool Validar(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length > 14)
                return false;
            while (cnpj.Length != 14)
                cnpj = '0' + cnpj;
            var igual = true;
            for (var i = 1; i < 14 && igual; i++)
                if (cnpj[i] != cnpj[0])
                    igual = false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
           
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}

