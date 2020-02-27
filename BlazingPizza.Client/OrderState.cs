using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class OrderState
    {
        public Pizza configuringPizza { get; private set; }
        public Order Order { get; private set; } = new Order();
        public bool showingConfigureDialog { get; private set; } // Pizza Customization Dialog Box
        public bool clickInsideBody { get; private set; } = false; // Pizza Customization Dialog Box
        public bool SignInclickInsideBody { get; private set; } = false; // Sign in Dialog Box
        public bool showSignIn { get; private set; } = false; // Sign in Dialog Box

        // sign in display
        #region
        public void SignInContinueConfigurePizzaDialog()
        {
            if(!SignInclickInsideBody)
                SignInclickInsideBody = true;
        }

        public void SignInExitConfigurePizzaDialog()
        {
            if (!SignInclickInsideBody)
                showSignIn = false;
            if(SignInclickInsideBody)
                SignInclickInsideBody = false;
        }

        public void ShowSignInOptions()
        {
            if(!showSignIn)
                showSignIn = true;
        }
        #endregion

        // pizza customization display
        #region
        public void ShowConfigurePizzaDialog(PizzaSpecial special)
        {
            configuringPizza = new Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>(),
            };

            showingConfigureDialog = true;
        }

        public void CancelConfigurePizzaDialog()
        {
            configuringPizza = null;
            showingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            Order.Pizzas.Add(configuringPizza);
            configuringPizza = null;

            showingConfigureDialog = false;
        }

        public void ContinueConfigurePizzaDialog()
        {
            clickInsideBody = true;
        }

        public void ExitConfigurePizzaDialog()
        {
            if (!clickInsideBody)
                CancelConfigurePizzaDialog();
            clickInsideBody = false;
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }
        #endregion

        // save and reload orders when navigated away on sign in
        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}
