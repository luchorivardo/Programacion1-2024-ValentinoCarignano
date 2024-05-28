using System.Data.SqlTypes;
using System.Threading;
using System.Threading.Tasks;

namespace El_Interes_es_Interesante
{

    /*
        Consigna: 
            En este ejercicio trabajará con cuentas de ahorro. Cada año, el saldo de su cuenta de ahorros se actualiza en función de su tasa de interés. La tasa de interés que le otorga su banco depende de la cantidad de dinero en su cuenta (su saldo):

            3,213% para un saldo negativo (el saldo se vuelve más negativo).
            0,5% para un saldo positivo inferior a 1000dólares.
            1,621% para saldo positivo mayor o igual a 1000 dólares y menor a 5000 dólares.
            2,475% para saldo positivo mayor o igual a 5000 dólares.

            Tiene cuatro tareas, cada una de las cuales se ocupará de su saldo y su tasa de interés.

            Tarea 1: Calcular la tasa de interés
               Implemente el método ( estático ) SavingsAccount.InterestRate() para calcular la tasa de interés en función del saldo especificado.
                   SavingsAccount.InterestRate(balance: 200.75m)
                   // 0.5f

            Tarea 2: Calcular el interes
               Implemente el método ( estático ) SavingsAccount.Interest() para calcular el interés en función del saldo especificado.
                   SavingsAccount.Interest(balance: 200.75m)
                   // 1.00375m

            Tarea 3: Calcular la actualización del balance anual
               Implementar el método ( estático ) SavingsAccount.AnnualBalanceUpdate() para calcular la actualización del saldo anual, teniendo en cuenta la tasa de interés.
                   SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
                   // 201.75375m

            Tarea 4: Calcula los años antes de alcanzar el saldo deseado
               Implemente el método ( estático ) SavingsAccount.YearsBeforeDesiredBalance() para calcular la cantidad mínima de años necesarios para alcanzar el saldo deseado dado el interés compuesto anual.
                   SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)
                   // 14
               Tenga en cuenta que el valor devuelto es un int.

        Al aplicar el interés simple a un saldo de capital, el saldo se multiplica por la tasa de interés y
        el producto de los dos es el monto del interés.

        El interés compuesto, por otro lado, se obtiene aplicando intereses de forma recurrente.
        En cada solicitud, el monto del interés se calcula y se suma al saldo de capital para que los cálculos de intereses
        posteriores estén sujetos a un saldo de capital mayor.
    */

    static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            float tasaInteres = 0;

            if (balance < 0)
            {
                tasaInteres = 3.213f;
            }
            else if (balance < 1000)
            {
                tasaInteres = 0.5f;
            }
            else if (balance >= 1000 && balance < 5000)
            {
                tasaInteres = 1.621f;
            }
            else
            {
                tasaInteres = 2.475f;
            }

            return tasaInteres;
        }

        public static decimal Interest(decimal balance)
        {
            float tasaInteres = InterestRate(balance);
            decimal interes = ((decimal)tasaInteres / 100) * balance;

            return interes;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            decimal interes = Interest(balance);
            decimal balanceAnual = interes + balance;

            return balanceAnual;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 0;

            while (balance < targetBalance)
            {
                balance += Interest(balance);
                years++;
            }
            
            return years;
        }
    }
}
