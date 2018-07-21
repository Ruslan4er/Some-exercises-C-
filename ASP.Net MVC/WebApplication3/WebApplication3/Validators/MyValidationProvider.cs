using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using WebApplication3.Models;

namespace WebApplication3.Validators
{
    public class MyValidationProvider : ModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ModelBindingExecutionContext context)
        {
            if (metadata.ContainerType == typeof(Book))
            {
                return new ModelValidator[] { new BookPropertyValidator(metadata, context) };
            }

            if (metadata.ModelType == typeof(Book))
            {
                return new ModelValidator[] { new BookValidator(metadata, context) };
            }

            return Enumerable.Empty<ModelValidator>();
        }


    }

    public class BookPropertyValidator : ModelValidator
    {
        public BookPropertyValidator(ModelMetadata metadata, ModelBindingExecutionContext modelBindingExecutionContext)
            : base(metadata, modelBindingExecutionContext)
        {
        }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            if (container is Book b)
            {
                switch (Metadata.PropertyName)
                {
                    case "Name":
                        if (string.IsNullOrEmpty(b.Name))
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Name", Message="Введите название книги"}
                        };
                        }
                        break;
                    case "Author":
                        if (string.IsNullOrEmpty(b.Author))
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Author", Message="Введите автора книги"}
                        };
                        }
                        break;
                    case "Year":
                        if (b.Year < 1700 || b.Year > 2000)
                        {
                            return new ModelValidationResult[]{
                            new ModelValidationResult { MemberName="Year", Message="Недопустимый год"}
                        };
                        }
                        break;
                }
            }
            return Enumerable.Empty<ModelValidationResult>();
        }
    }

    public class BookValidator : ModelValidator
    {
        public BookValidator(ModelMetadata metadata, ModelBindingExecutionContext modelBindingExecutionContext)
            : base(metadata, modelBindingExecutionContext)
        {
        }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            var book = (Book)Metadata.Model;

            var errors = new List<ModelValidationResult>();

            if (book.Author == "Автор 1" && book.Year > 2200)
            {
                errors.Add(new ModelValidationResult { MemberName = "", Message = "Недопустимая книга" });
            }
            return errors;
        }
    }
}