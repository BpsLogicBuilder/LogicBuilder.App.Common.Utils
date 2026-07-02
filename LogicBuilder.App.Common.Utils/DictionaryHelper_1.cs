using LogicBuilder.App.Common.Utils.Interfaces;
using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;

namespace LogicBuilder.App.Common.Utils
{
#pragma warning disable S2436
    public static class DictionaryHelper<TSource, TKey, TValue>//NOSONAR - rules engine supports generic classes but not generic methods
#pragma warning restore S2436
    {
        [AlsoKnownAs("ToDictionary")]
        [FunctionGroup(FunctionGroup.Standard)]
        public static IDictionary<TKey, TValue> ToDictionary(IDictionaryHelper dictionaryHelper, IEnumerable<TSource> enumerable, SelectorLambdaOperatorParameters keySelector, SelectorLambdaOperatorParameters valueSelector)
            => dictionaryHelper.ToDictionary<TSource, TKey, TValue>(enumerable, keySelector, valueSelector);
    }
}
