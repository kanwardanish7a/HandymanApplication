using HandyApp.Samples;
using Xunit;

namespace HandyApp.MongoDB.Domains;

[Collection(HandyAppTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<HandyAppMongoDbTestModule>
{

}
