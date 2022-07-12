# Open Api

Open Api is the standard for describing Apis. 
* [Open Api Getting Started](https://oai.github.io/Documentation/start-here.html)
* [Open Api Specification](https://spec.openapis.org/oas/v3.1.0)




https://stevetalkscode.co.uk/openapireference-commands


NSwag Code in seperate files
* https://github.com/RicoSuter/NJsonSchema/issues/514


There are two applications that can be used in the dotnet space NSwag and Swashbuckle.

* [NSwag vs Swashbuckle]()

NSwag is apparently a more complete toolchain for all operations. Swashbuckle is just the UI and descriptors although it does have a [codegen library](https://github.com/domaindrivendev/Swashbuckle.AspNetCore#swashbuckleaspnetcoreswaggergen) so not sure here.

## NSwag

[NSwag](https://github.com/RicoSuter/NSwag/wiki) is the Open Api tool chain for .net. The documentation is pretty comprehensive. The tools include command line runners aswell as NSwagStudio which is a windows OS UI. 

Install NSwag from npm:
```
npm install nswag -g
```

The [Nswag CommandLine](https://github.com/RicoSuter/NSwag/wiki/CommandLine) docs describe the process of running via the `NSwag.exe` command.

Create a config file with the new command
```
nswag new
```
This will create a new config file called NSwag.json. 
* [NSwag Configuration](https://github.com/RicoSuter/NSwag/wiki/NSwag-Configuration-Document)
We need to update the config file with the following values:
* Update the `runtime` to `net60`
* Update the `output` option for each generator that you want to run to a file name, e.g. `client.cs` 
* The `documentGenerator` generates `json` from the `yaml`


```
nswag run nswag.json
```