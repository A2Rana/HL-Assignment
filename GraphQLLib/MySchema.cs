using GraphQL.Types;

namespace GraphQLLib
{
    public class MySchema
    {
        private ISchema _schema { get; set; }
        public ISchema GraphQLSchema
        {
            get
            {
                return this._schema;
            }
        }

        public MySchema()
        {
            this._schema = Schema.For(@"
          type LocationModel {
            id: ID,
            name: String,
            type: String,
            latitude: Decimal,
            longitude: Decimal,
            city: String, 
            state: String,
            marketID: ID,
            marketName: String
          }

          type ApiHome {
            homeId: ID,
            listingId: Int,
            listingTitle: String,
            listingNumber: String,
            isSpec: Boolean,
            planId: Int,
            planName: String,
            commDesc: String,
            communityUrl: String,
            commAddr: String,
          } 

          type Query {
              hello: String,
              checkLocationInput(partnerId: ID, searchTerm: String): String,
              checkHomeInput(partnerId: ID, planId: Int): String,
              locations(partnerId: ID, searchTerm: String): [LocationModel],
              homedetails(partnerId: ID, planId: Int) : [ApiHome]
              pello: String
          }
      ", _ =>
            {
                _.Types.Include<Query>();
            });
        }

    }
}
