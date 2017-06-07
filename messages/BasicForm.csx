using System;
using Microsoft.Bot.Builder.FormFlow;

public enum CarOptions { Dining = 1, Events, Friends };
public enum diningOptions { Chinese = 1, Mexican, Italian };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! What is your {&}?")]
    public string Name { get; set; }

    [Prompt("What are you looking to do {||}")]
    public CarOptions Car { get; set; }

    [Prompt("What type of food do you want {&} {||}")]
    public diningOptions Color { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
