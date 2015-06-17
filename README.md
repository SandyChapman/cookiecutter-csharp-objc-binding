# cookiecutter-csharp-objc-binding
A CookieCutter template for generating a C# binding project for binding an Objective-C static library.

It is recommended to first generate the ApiDefinition file using [Objective Sharpie](http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/objective_sharpie/) provided by Xamarin.

Then, execute the cookie cutter using a Python script that will substitute the `api_definition` value in the `cookiecutter.json` file and will copy your static library.

# Example Python Usage:

```
with open('path/to/ApiDefinitions.cs') as apis:
            cookiecutter('gh:SandyChapman/cookiecutter-csharp-objc-binding',
                         extra_context={'api_definition': apis.read().replace('\n', '\n\t'),
                                        'library_name': 'MyLibrary'},
                         no_input=True)
            shutil.copyfile('./libMyLibrary.a', './XamarinBinding/XamarinBinding/libMyLibrary.a')
```

Alternatively, you can manually copy the library file into the project and copy-paste your API definition as desired.
