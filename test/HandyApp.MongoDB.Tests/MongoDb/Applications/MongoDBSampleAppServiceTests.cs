using HandyApp.MongoDB;
using HandyApp.Samples;
using Xunit;

namespace HandyApp.MongoDb.Applications;

[Collection(HandyAppTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<HandyAppMongoDbTestModule>
{

}
