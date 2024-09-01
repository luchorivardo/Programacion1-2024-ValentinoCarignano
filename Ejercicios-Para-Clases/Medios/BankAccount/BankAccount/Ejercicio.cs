using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    /*
    Consigna:
        Después de años de completar formularios y esperar, finalmente ha obtenido su licencia bancaria. Esto significa que ahora es oficialmente elegible para abrir su propio banco, ¡hurra!

        Tu primera prioridad es poner en funcionamiento los sistemas informáticos. Después de un día de arduo trabajo, ya podrás abrir y cerrar cuentas, así como gestionar retiros y depósitos.

        Como no te molestaste en escribir pruebas, invitas a algunos amigos a que te ayuden a probar el sistema. Sin embargo, después de solo cinco minutos, ¡uno de tus amigos afirma que perdió dinero! Aunque estás seguro de que tu código no tiene errores, comienzas a revisar los registros para investigar.

        Ah, sí, tal como sospechabas, ¡tu amigo tiene la culpa! Compartieron sus credenciales de prueba con otro amigo y juntos conspiraron para realizar depósitos y retiros de la misma cuenta en paralelo . ¿Quién haría algo así?

        Mientras argumentas que es físicamente imposible que alguien acceda a su cuenta en paralelo, tu amigo te notifica con aire de superioridad que las normas bancarias exigen que admitas esta opción. Por lo tanto, si no hay compatibilidad con la banca paralela, no hay señal de lanzamiento. Suspirando, creas una nota mental para trabajar en esto mañana. Esto retrasará tu fecha de lanzamiento al menos un día más, pero bueno...

        Instrucciones
        Su tarea es implementar cuentas bancarias que admitan apertura/cierre, retiros y depósitos de dinero.

        Como se puede acceder a las cuentas bancarias de muchas maneras diferentes (Internet, teléfonos móviles, cargos automáticos), el software de su banco debe permitir que se pueda acceder a las cuentas de forma segura desde varios subprocesos/procesos (la terminología depende del lenguaje de programación que utilice) en paralelo. Por ejemplo, puede haber muchos depósitos y retiros en paralelo; debe asegurarse de que no haya condiciones de competencia entre el momento en que lee el saldo de la cuenta y el momento en que establece el nuevo saldo.

        Debería ser posible cerrar una cuenta; las operaciones contra una cuenta cerrada deben fallar.

        Este ejercicio requiere que manejes datos relacionados con divisas y dinero. Un enfoque normal es utilizar el decimal . Sin embargo, ten en cuenta que, en este caso, solo almacenarás el valor numérico de una divisa.
    */

    public class BankAccount
    {
        public void Open()
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public void Close()
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public decimal Balance
        {
            get
            {
                throw new NotImplementedException("You need to implement this property.");
            }
        }

        public void UpdateBalance(decimal change)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
