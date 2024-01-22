﻿using Microsoft.Extensions.DependencyInjection;
using TagsCloudContainer.Interfaces;
using TagsCloudContainer.Readers;
using TagsCloudContainer.TagsCloud;

namespace TagsCloudContainer
{
    public class Startup
    {
        public static ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
            .AddSingleton<IFileReader, TxtReader>()
            .AddSingleton<IPreprocessor, WordPreprocessor>()
            .AddSingleton<IImageSettings, ImageSettings>()
            .AddSingleton<ITagCloudGenerator, TagCloudGenerator>()
            .AddSingleton<ITagCloudClient, CommandLineClient>()
            .AddScoped(provider =>
            {
                var fileReader = provider.GetRequiredService<IFileReader>();
                var preprocessor = provider.GetRequiredService<IPreprocessor>();
                var tagCloudGenerator = provider.GetRequiredService<ITagCloudGenerator>();
                var imageSettings = provider.GetRequiredService<IImageSettings>();


                return new TagCloudApp(preprocessor, imageSettings);
            })
            .BuildServiceProvider();
        }      
    }
}
