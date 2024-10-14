using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

public class EmailTagHelper : TagHelper
{
	public string Endereco {  get; set; }

	public string Conteudo { get; set; }

	public override Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "a";
		output.Attributes.SetAttribute("href", "mailto:" + Endereco);
		output.Content.SetContent(Conteudo);
	}
}
